using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// gebruik de map Model, die de Classes bevat
using WindowsFormsAppExamplesRWA.Model;

namespace WindowsFormsAppExamplesRWA
{
    public class DAL
    {
        string connectionString = @"Data Source=.;Initial Catalog=B2C2WinformsOefening;Integrated Security=True";
        


        public List<ParentClass> ParentClassList = new List<ParentClass>();

        public DAL() { }    

        // >>>>>>>>>>>>>>>>>>>>> PARENT - CHILD - SUB <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // >>>>>>>>>>>>>>>>>>>>> PARENT - CHILD - SUB <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        // >>>>>>>>>>>>> (Handmatig gevulde) Test Populatie <<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public void PopulateModelLocally()
        {
            ParentClassList.Clear();
            // Populate Model with Testdata
            ParentClass parentClass = new ParentClass(3, "Huis", "Bewoond");
            parentClass.ListOfChildClasses.Add(new ChildClass(1, "Woonkamer", parentClass));
            parentClass.ListOfChildClasses.Add(new ChildClass(2, "Keuken", parentClass));
            parentClass.ListOfChildClasses.Add(new ChildClass(3, "Slaapkamer", parentClass));
            parentClass.ListOfChildClasses.Add(new SubClass(4, "Slaapkamer", parentClass, "Hobbykamer"));
            ParentClassList.Add(parentClass);
            parentClass = new ParentClass(4, "Een", "Actief");
            parentClass.ListOfChildClasses.Add(new ChildClass(4, "1 van Veel", parentClass));
            parentClass.ListOfChildClasses.Add(new ChildClass(5, "2 van Veel", parentClass));
            ParentClassList.Add(parentClass);
        }

        // >>>>>>>>>>>>> Populatie vanuit Database <<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public void PopulateModelFromDB()
        {
            // Volg Structuur van Data in Database: 
            //  Eerst ParentClass, daarna ChildClass/SubClass

            // Maak lijst leeg
            ParentClassList.Clear();

            // VUL ParentClass
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT ID, Name, Status FROM tblParent ORDER BY ID";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            ParentClassList.Add(new ParentClass(Int32.Parse(dataReader[0].ToString())
                                                               , dataReader[1].ToString()
                                                               , dataReader[2].ToString()
                                                               )
                                             );
                        }
                    }
                }
            }
            // VUL ChildClass en SubClass per ParentClass
            for (int i = 0; i < ParentClassList.Count; i++)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT ID, Name, ClassType, ExtraAttribute FROM tblChild WHERE ParentID = @Id ORDER BY ID";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", ParentClassList[i].Id);
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                if (dataReader[2].ToString() == "SubClass")
                                {
                                    ParentClassList[i].ListOfChildClasses.Add(new SubClass(Int32.Parse(dataReader[0].ToString())
                                                                             , dataReader[1].ToString()
                                                                             , ParentClassList[i]
                                                                             , dataReader[3].ToString()
                                                                             ));
                                }
                                else
                                {
                                    ParentClassList[i].ListOfChildClasses.Add(new ChildClass(Int32.Parse(dataReader[0].ToString())
                                                                             , dataReader[1].ToString()
                                                                             , ParentClassList[i]
                                                                             ));
                                }
                            }
                        }
                    }
                    cnn.Close();
                }

            }
        }

        // >>>>>>>>>>>>> INSERT, UPDATE, DELETE in Database <<<<<<<<<<<<<<<<<<<<
        public void InsertParent(string name, string status)
        {
            SqlConnection cnn = new SqlConnection();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                string sql = "INSERT INTO tblParent (Name, Status) VALUES (@Name, @Status)";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { cnn.Dispose(); }
        }
        public void UpdateParent(int Id, string name, string status)
        {
            SqlConnection cnn = new SqlConnection();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                string sql = "UPDATE tblParent SET Name = @name, Status = @Status WHERE ID = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { cnn.Dispose(); }
        }
        public void DeleteParent(int Id)
        {
            SqlConnection cnn = new SqlConnection();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                string sql = "DELETE tblParent WHERE ID = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { cnn.Dispose(); }
        }

        public void InsertChild(int parentId, string name, string extraAttribute)
        {
            SqlConnection cnn = new SqlConnection();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                string sql = "INSERT INTO tblChild (ParentID, Name, ClassType, ExtraAttribute) VALUES (@ParentId, @Name, @ClassType, @ExtraAttribute)";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@ParentId", parentId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    if (extraAttribute is null)
                    {
                        cmd.Parameters.AddWithValue("@ClassType", "ChildClass");
                        cmd.Parameters.AddWithValue(string.Empty, extraAttribute);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ClassType", "SubClass");
                        cmd.Parameters.AddWithValue("@ExtraAttribute", extraAttribute);
                    }
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { cnn.Dispose(); }
        }
        public void UpdateChild(int Id, string name, string extraAttribute)
        {
            SqlConnection cnn = new SqlConnection();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                string sql = "UPDATE tblChild SET Name = @Name, extraAttribute = @ExtraAttribute WHERE ID = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@ExtraAttribute", extraAttribute);
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { cnn.Dispose(); }
        }
        public void DeleteChild(int Id)
        {
            SqlConnection cnn = new SqlConnection();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                string sql = "DELETE tblChild WHERE ID = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { cnn.Dispose(); }
        }

        public void SearchDataInDB(string parentName, string childName)
        {
            // Volg Structuur van Data in Database: 
            //  Eerst ParentClass, daarna ChildClass/SubClass

            // Maak lijst leeg
            ParentClassList.Clear();

            // VUL ParentClass
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT ID, Name, Status, Boel FROM tblParent WHERE (Name = @Name OR Name LIKE @LikeName) ORDER BY ID";
                    cmd.Parameters.AddWithValue("@Name", parentName);
                    cmd.Parameters.AddWithValue("@LikeName", ('%' + parentName + '%'));
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            ParentClassList.Add(new ParentClass(Int32.Parse(dataReader[0].ToString())
                                                               , dataReader[1].ToString()
                                                               , dataReader[2].ToString()
                                                               )
                                             );
                        }
                    }
                }
            }
            // VUL ChildClass en SubClass per ParentClass
            for (int i = 0; i < ParentClassList.Count; i++)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT ID, Name, ClassType, ExtraAttribute FROM tblChild WHERE ParentID = @Id AND (Name = @Name OR Name LIKE @LikeName) ORDER BY ID";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", ParentClassList[i].Id);
                        cmd.Parameters.AddWithValue("@Name", childName);
                        cmd.Parameters.AddWithValue("@LikeName", ('%' + childName + '%'));
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                if (dataReader[2].ToString() == "SubClass")
                                {
                                    ParentClassList[i].ListOfChildClasses.Add(new SubClass(Int32.Parse(dataReader[0].ToString())
                                                                             , dataReader[1].ToString()
                                                                             , ParentClassList[i]
                                                                             , dataReader[3].ToString()
                                                                             ));
                                }
                                else
                                {
                                    ParentClassList[i].ListOfChildClasses.Add(new ChildClass(Int32.Parse(dataReader[0].ToString())
                                                                             , dataReader[1].ToString()
                                                                             , ParentClassList[i]
                                                                             ));
                                }
                            }
                        }
                    }
                    cnn.Close();
                }

            }
        }

        // >>> !!! INSTRUCTIE !!! <<<
        // Maak Database (SQL Management Studio)
        // Maak Connectie met Database vanuit Visual Studio
        // Wijzig de connectionString naar je eigen connectionString (staat in Properties van de DB Connectie)
        // Voer onderstaande CREATE SCRIPTS uit in Database
        // Voer gegevens in in Database
        /*
        CREATE TABLE [dbo].[tblParent](
	    [ID] [int] IDENTITY(1,1) NOT NULL,
	    [Name] [nvarchar](50) NULL,
	    [Status] [nvarchar](50) NULL,
        CONSTRAINT [PK_tblParentTable] PRIMARY KEY CLUSTERED 
        ([ID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]
        GO
        CREATE TABLE [dbo].[tblChild](
	    [ID] [int] IDENTITY(1,1) NOT NULL,
	    [Name] [nvarchar](50) NULL,
	    [ParentID] [int] NOT NULL,
	    [ClassType] [nvarchar](50) NOT NULL,
	    [ExtraAttribute] [nvarchar](50) NULL,
        CONSTRAINT [PK_tblChild] PRIMARY KEY CLUSTERED 
        ([ID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]
        GO
        ALTER TABLE [dbo].[tblChild]  WITH CHECK ADD CONSTRAINT [FK_tblChild_tblChild] FOREIGN KEY([ParentID])
        REFERENCES [dbo].[tblParent] ([ID])
        GO
        ALTER TABLE [dbo].[tblChild] CHECK CONSTRAINT [FK_tblChild_tblChild]
        GO
         */

    }
}

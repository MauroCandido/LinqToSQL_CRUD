using System;
using System.Data.Linq;
using System.Linq;
using System.Collections.Generic;


namespace DAL
{
    public class DBAccess
    {
        // metodo static. Nao preciso criar instancia da DBACCESS
        public static Table<people> GetPeople()
        {
            peopleDataContext dc = new peopleDataContext();
                try
                {
                    return dc.GetTable<people>();
                }
                catch (Exception)
                {
                    throw;
                }
        }

        public static IQueryable<people> GetIQueryablePeople()
        {
            peopleDataContext dc = new peopleDataContext();
                try
                {
                    return dc.GetTable<people>();
                }
                catch (Exception)
                {
                    throw;
                }
        }

        // LINQ to GET PEOPLE
        public static people GetPeopleID(int idcode)
        {
            peopleDataContext dc = new peopleDataContext();
                try
                {
                    // This is LINQ Syntax to return just the record passed via ID
                    return (from gente in dc.GetTable<people>()
                            where (gente.Id == idcode)
                            select gente).SingleOrDefault<people>();
                }
                catch (Exception)
                {
                    throw;
                }
        }

        //delete people
        public static void DeletePeople(int idcode)
        {
            // Always use context on LINQ to SQL.. MC 28/05/2017
            peopleDataContext dc = new peopleDataContext();
            try
            {       
                    /*  var findPeople = (from gente in dc.GetTable<people>()
                                            where (gente.Id == idcode)
                                            select gente).SingleOrDefault<people>();
                                            */

                    // Call from getPeopleID function .. to create a clean code.
                    var findPeople = GetPeopleID(idcode);

                    if  (findPeople != null)
                    {
                        try
                        {
                            dc.peoples.Attach(findPeople);
                            dc.peoples.DeleteOnSubmit(findPeople);
                            dc.SubmitChanges();
                        }
                        catch(Exception)
                        {
                            throw;
                        }
                    }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ManuPeople(people _People)
        {
            peopleDataContext dc = new peopleDataContext();
            {
                // here we have the update or Insert
                //// --  var findPeople = getPeopleID(_People.Id);
                var findPeople = (from gente in dc.GetTable<people>()
                                  where (gente.Id == _People.Id)
                                  select gente).SingleOrDefault<people>();
                
                if (findPeople == null)
                {
                    try
                    {
                        people people = new people();
                        people.Id = _People.Id;
                        people.name = _People.name;
                        people.phone = _People.phone;
                        people.age = _People.age;

                        Table<people> peopleInsert = GetPeople();
                        peopleInsert.InsertOnSubmit(people);
                        peopleInsert.Context.SubmitChanges();
                    }
                    catch(Exception)
                    {
                        // better way, because you can capture ALL exception and use it as IS
                        throw;
                    }
                }
                else
                {
                    try
                    {
                        //use the findPeople on CONTEXT
                        findPeople.Id = _People.Id;
                        findPeople.name = _People.name;
                        findPeople.phone = _People.phone;
                        findPeople.age = _People.age;
                        dc.SubmitChanges();
                     
                    }
                    catch (Exception)
                    {
                        // better way, because you can capture ALL exception and use it as IS
                        throw;
                    }
                }

            }

                
        }
    }
}



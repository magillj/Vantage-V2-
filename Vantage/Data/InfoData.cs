using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Vantage.Data
{
    public static class InfoData
    {
        public class Member
        {
            private string firstName;
            private string lastName;
            private string email;
            private string major;
            private int initiation;

            public Member(string firstName, string lastName, string email, string major, int initiation)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Email = email;
                this.Major = major;
                this.Initiation = initiation;
            }

            public string FirstName
            {
                get
                {
                    return firstName;
                }

                set
                {
                    firstName = value;
                }
            }

            public string LastName
            {
                get
                {
                    return lastName;
                }

                set
                {
                    lastName = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }
            }

            public string Major
            {
                get
                {
                    return major;
                }

                set
                {
                    major = value;
                }
            }

            public int Initiation
            {
                get
                {
                    return initiation;
                }

                set
                {
                    initiation = value;
                }
            }
        }
        public static List<Member> GetMembers(string fileName)
        {
            List<Member> result = new List<Member>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // TODO: Parse line and make Member object
                }
            }
            return result;
        }
    }
}
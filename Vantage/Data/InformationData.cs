using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Vantage.Data
{
    public static class InformationData
    {
        public class Member
        {
            private string firstName;
            private string lastName;
            private string email;
            private string phoneNumber;
            private string initiation;

            public Member(string firstName, string lastName, string email, string phoneNumber, string initiation)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Email = email;
                this.PhoneNumber = phoneNumber;
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

            public string PhoneNumber
            {
                get
                {
                    return phoneNumber;
                }

                set
                {
                    phoneNumber = value;
                }
            }

            public string Initiation
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
            List<List<string>> data = new List<List<string>>() {
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>()
            };
            List<Member> result = new List<Member>();
            var count = 0;
            StreamReader reader = new StreamReader(fileName);
            string line;
            /* Categories are seperated by blank line */
            while ((line = reader.ReadLine()).Length > 0)
            {
                count++;
            }
            reader = new StreamReader(fileName);
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < count; j++)
                {
                    data[i].Add(reader.ReadLine());
                }
                /* Account for blank line seperator */
                reader.ReadLine();
            }
            for (var i = 0; i < count; i++)
            {
                result.Add(new Member(data[0][i], data[1][i],
                    data[2][i], data[3][i], data[4][i]));
            }
            return result;
        }

        public static List<Member> GetTestMembers()
        {
            return new List<Member>()
            {
                new Member("Derek", "Coley", "dmcoley@uw.edu",
                "Computer Science", "1782")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x
{
    public class DomesticStudent : Student
    {
        //public properties-------------------------------------------
        public string DomesticAddress { get; private set; }// READ ONLY

        

        /// <summary>
        ///  CONSTRUCTORS - takes three arguments - name(string), age(int) , studentID(string)   
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>

        public DomesticStudent(string name, int age, string studentID)
            :base(name,age, studentID)
        {
            
        }

        //PUBLIC METHODS--------------------------------------------

            /// <summary>
            /// This method sets the domestic address property
            /// </summary>
            /// <param name="address"></param>
        public void SetDomesticAddress(string address)
        {
            this.DomesticAddress = address;
        }


    }
}
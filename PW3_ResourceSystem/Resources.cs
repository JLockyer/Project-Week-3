using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PW3_ResourceSystem
{
    //View all resources from ".txt" file. **(Completed/Not Tested)**
    //Edit check(out/in) sysytem to compile with program/classes
    //Write resources to ".txt" file including type of resource in "()"
    //Write ".txt" file for each resource type
    //Currently checked out file
    

    abstract class Resources
    {
        Dictionary<string, int> studentID = new Dictionary<string, int>()
        { {"Bob Jones", 00120 }, {"Chad Lego", 00121 }, {"Dale Earnie", 00122 }, {"Jack Johnson", 00123 }, {"Ricky Bobby", 00124 } };
        List<string> bobJones = new List<string>() { };
        List<string> chadLego = new List<string>() { };
        List<string> daleEarnie = new List<string>() { };
        List<string> jackJohnson = new List<string>() { };
        List<string> rickyBobby = new List<string>() { };

        private string title;
        private int isbnNum;
        private int length;
        private string status;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int ISBN { get; set; }
        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public virtual void Edit()
        {
            
        }

        public virtual void Checkout()
        {
            
        }

        public virtual void Return()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWorker
{
   
    public class Works
    {
        private int worksID;
        private string name;
        private string number;
        private string locate;
        private string request;
        private string problemImage;

        public Works(int worksID, string name, string number, string locate, string request, string problemImage)
        {
            this.WorksID = worksID;
            this.Name = name;
            this.Number = number; 
            this.Locate = locate;
            this.Request = request;
            this.ProblemImage = problemImage;
        }

        public int WorksID { get => worksID; set => worksID = value; }
        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public string Locate { get => locate; set => locate = value; }
        public string Request { get => request; set => request = value; }
        public string ProblemImage { get => problemImage; set => problemImage = value; }
    }
}

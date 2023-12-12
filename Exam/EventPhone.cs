using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQ2
{
    public class EventPhone : EventArgs
    {
        public string Messgae { get; set; }
        public EventPhone(string message)
        {
            Messgae = message;
        }
    }

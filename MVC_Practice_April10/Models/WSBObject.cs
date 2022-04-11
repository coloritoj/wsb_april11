using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Practice_April10.Models
{
    public class WSBObject
    {
        public int no_of_comments { get; set; }

        public string sentiment { get; set; }

        public decimal sentiment_score { get; set; } 
    
        public string ticker { get; set; }

        public WSBObject()
        {

        }

        public WSBObject(int no_of_comments, string sentiment, decimal sentiment_score, string ticker)
        {
            this.no_of_comments = no_of_comments;
            this.sentiment = sentiment;
            this.sentiment_score = sentiment_score;
            this.ticker = ticker;
        }
    }
}

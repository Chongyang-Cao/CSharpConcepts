﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises.Diary
{
    public class DiaryEvent
    {
       
        private TimeOnly _lunchTime = new(12, 0);
        
        public DateOnly Date { get; private set; }
        public TimeOnly Time { get; private set; }
        public int Minutes { get; private set; }
        public string Description { get; private set; }
        public string Location { get; private set; }
        public bool IsMorning { get
            {
                return Time < _lunchTime;
            } }

        // Constructor
        public DiaryEvent(DateOnly date, TimeOnly time, int minutes, string description, string location)
        {
            Date = date;
            Time = time;
            Minutes = minutes;
            Description = description;
            Location = location;
        }
            
    }
}

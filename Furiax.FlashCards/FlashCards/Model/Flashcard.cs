﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Model
{
	internal class Flashcard
	{
        public int FlashcardId { get; set; }
        public int StackId { get; set; }
        public string FrontText { get; set; }
        public string BackText { get; set; }
    }
}

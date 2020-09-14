using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
    class Bishop : Piece
    {
        public Bishop() : base("Bishop"){}

        public override bool Move(string fromPosition, string toPosition)
        {
            var ColoumMove = fromPosition[0] - toPosition[0];
            var RowMove = fromPosition[1] - toPosition[1];

            return Math.Abs(RowMove) == Math.Abs(ColoumMove);
        }
    }
}

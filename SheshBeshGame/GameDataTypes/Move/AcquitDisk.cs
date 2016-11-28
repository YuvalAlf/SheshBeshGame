﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SheshBeshGame.Utils;

namespace SheshBeshGame.GameDataTypes.Move
{
    public sealed class AcquitDisk : SingleGameMove
    {
        public int SourceColumn { get; }

        public AcquitDisk(int sourceColumn)
        {
            SourceColumn = sourceColumn;
        }

        public override Board DoMove(Board board)
        {
            var newColumns = board.columns.Copy();
            newColumns[SourceColumn] = newColumns[SourceColumn].LessDisk();
            return new Board(board.eatenWhites, board.eatenBlacks, newColumns);
        }
    }
}
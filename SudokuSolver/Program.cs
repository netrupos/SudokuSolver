﻿using System;
using System.Collections.Generic;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> grid = new List<List<int>>();
            grid.Add(new List<int> { 0, 8, 1, 0, 4, 0, 0, 0, 0 });
            grid.Add(new List<int> { 0, 5, 6, 9, 0, 7, 4, 0, 0 });
            grid.Add(new List<int> { 0, 0, 0, 0, 1, 5, 0, 9, 0 });
            grid.Add(new List<int> { 0, 0, 0, 0, 0, 3, 8, 5, 7 });
            grid.Add(new List<int> { 8, 4, 0, 0, 6, 0, 0, 2, 3 });
            grid.Add(new List<int> { 7, 3, 9, 2, 0, 0, 0, 0, 0 });
            grid.Add(new List<int> { 0, 0, 8, 3, 0, 6, 5, 7, 0 });
            grid.Add(new List<int> { 0, 6, 0, 5, 8, 0, 0, 0, 0 });
            grid.Add(new List<int> { 0, 0, 0, 0, 7, 0, 3, 6, 0 });

            SudokuHelper helper = new SudokuHelper();
            helper.PrintGrid(grid);
            helper.Solve(grid);
        }
    }
}

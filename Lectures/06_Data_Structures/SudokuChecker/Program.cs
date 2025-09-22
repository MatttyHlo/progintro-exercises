int[,] sudokuBoard = new int[9, 9]
{
    { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
    { 6, 5, 2, 1, 9, 5, 3, 4, 8 },
    { 1, 9, 8, 3, 4, 2, 5, 6, 7 },

    { 8, 2, 9, 7, 6, 1, 4, 5, 3 },
    { 4, 6, 1, 8, 5, 3, 7, 9, 2 },
    { 7, 4, 3, 9, 2, 6, 8, 5, 1 },

    { 9, 7, 6, 5, 3, 4, 2, 8, 1 },
    { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
    { 3, 1, 5, 2, 8, 7, 1, 6, 9 }
};

bool correct = true;

for (int i = 0; i < 9; i++)
{
    int[] row = new int[9];
    for (int j = 0; j < 9; j++)
    {
        if (row.Contains(sudokuBoard[i, j]))
        {
            correct = false;
            break;
        }
        row[i] = sudokuBoard[i, j];
    }
}

for (int i = 0; i < 9; i++)
{
    int[] column = new int[9];
    for (int j = 0; j < 9; j++)
    {
        if (column.Contains(sudokuBoard[j, i]))
        {
            correct = false;
            break;
        }
        column[i] = sudokuBoard[j, i];
    }
}

int[][] squares = new int[9][];
for(int i = 0; i < 9; i++)
{
    squares[i] = new int[9];
}

for (int i = 0; i < 9; i++)
{

    for (int j = 0; j < 9; j++)
    {
        if (squares[(i / 3) * 3 + j / 3].Contains(sudokuBoard[j, i])) //Checking the right square - calculating rthe right square
        {
            correct = false;
            break;
        }
        squares[(i / 3) * 3 + j / 3][(i % 3) * 3 + j % 3] = sudokuBoard[j, i];
    }
}

Console.WriteLine(correct);




int[,] array = new int[,]

{

    { 1, 4, 7 },

    { 2, 5, 9 },

    { 2, 3, 8 },

    { 4, 2, 4 },

    { 5, 2, 6 },

    { 7, 9, 1 }

};



int min = array[0, 0];

int minRow = 0;

int minCol = 0;



// Находим наименьший элемент в массиве и его индексы

for (int i = 0; i < array.GetLength(0); i++)

{

    for (int j = 0; j < array.GetLength(1); j++)

    {

        if (array[i, j] < min)

        {

            min = array[i, j];

            minRow = i;

            minCol = j;

        }

    }

}



int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

int rowIndex = 0;

int colIndex = 0;



// Копируем элементы массива в новый массив, пропуская строку и столбец с наименьшим элементом

for (int i = 0; i < array.GetLength(0); i++)

{

    if (i != minRow)

    {

        for (int j = 0; j < array.GetLength(1); j++)

        {

            if (j != minCol)

            {

                result[rowIndex, colIndex] = array[i, j];

                colIndex++;

            }

        }

        rowIndex++;

        colIndex = 0;

    }

}



// Выводим результат

for (int i = 0; i < result.GetLength(0); i++)

{

    for (int j = 0; j < result.GetLength(1); j++)

    {

        Console.Write(result[i, j] + " ");

    }

    Console.WriteLine();

}
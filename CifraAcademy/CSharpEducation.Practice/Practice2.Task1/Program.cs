using static System.Console;

for (int i = 0; i < 10; i++)
{
    Write(i);
}

WriteLine();

int j = 0;

while (j < 10)
{
    Write(j);
    j++;
    //if (j >= 10) break ;
}

WriteLine();

j = 0;
do
{
    Write(j);
    j++;
}
while (j < 10);

WriteLine();

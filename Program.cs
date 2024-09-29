using System;

Random random = new Random();
int rows = random.Next(8,13);

static void PlainPizza(int rows) {
    for (int i = rows; i >=1; i--){
        for (int j = 1; j <=i; j++) {
                Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void CheesePizza(int rows) {
    for (int i = rows; i >=1; i--){
        for (int j = 1; j <=i; j++) {
            if(i == rows || j == 1 || j == i){
                Console.Write("*");
            }
            else {
                Console.Write("#");
            }
        }
        Console.WriteLine();
    }
}

static void PepperoniPizza(int rows) {
    Random random = new Random();
    for (int i = rows; i >=1; i--){
        for (int j = 1; j <=i; j++) {
            if(i == rows || j == 1 || j == i){
                Console.Write("*");
            }
            else {
                if(random.Next(100) < 10 && j < i - 1){
                    Console.Write("[]");
                    j++;
                }
                else{
                    Console.Write("#");
                }
            }
        }
        Console.WriteLine();
    }
}

static void PizzaChoose(string selectPizza, int rows) {
    if (selectPizza == "1") {
        PlainPizza(rows);
    }
    else if (selectPizza == "2") {
        CheesePizza(rows);
    }
    else if (selectPizza == "3") {
    PepperoniPizza(rows);
    }
}

Console.WriteLine("please enter a number to display a slice of pizza\n1: plain pizza\n2: cheese pizza\n3: pepperoni pizza");
string selectPizza = Console.ReadLine();
PizzaChoose(selectPizza, rows);

while (selectPizza != "1" & selectPizza != "2" & selectPizza != "3"){
    Console.WriteLine("please enter a valid input, or press q to exit the program.");

    selectPizza = Console.ReadLine();
    
    if (selectPizza == "q"){
        break;
    }
    else {
        PizzaChoose(selectPizza, rows);
    }
    
}
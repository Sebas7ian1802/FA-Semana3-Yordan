from Cuadrado import Cuadraro
c = Cuadraro()

def menu1():
    print("Bienvenidos al sistema de áreas y perímetros")
    print("**************Menu de opciones**************")
    print("*    1. Triangulo                          *")
    print("*    2. Cuadrado                           *")
    print("*    3. Rectangulo                         *")
    print("*    4. Trapecio                           *")
    print("*    5. Salir                              *")
    print("********************************************")

def menu2():
    print("********************************************")
    print("*    1. Area                               *")
    print("*    2. Perimetro                          *")
    print("********************************************")

    opcion2 = int(input("Ingrese la opcion: "))
    return opcion2

while True:
    menu1()
    while True:
        opcion = int(input("Seleccione una opcion: "))
        if opcion in (0,1,2,3,4):
            break
        else: print("Opicion no valida. Ingresa un numero nuevamente.\n")

    match opcion:
        case 0: quit() #exit()
        case 1: 
            opc2() = menu2()
            match opc2:
                case 1:t.area()
                case 2:t.perimetro()
            
        case 2: print()
        case 3: print()
        case 4: print()

    while True:
        conti = input("Desea continuar? (s/n): ")
        if conti in ("s", "n"): break
        else: print("Error. Presione solo 's' o 'n' .")

    if conti == "n": break
       




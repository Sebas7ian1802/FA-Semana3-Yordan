
def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido al curso de fudamentos de algoritmo de la carrera {carrera}")

def ejer2():
    print("\"Yordan\"")

def ejer3():
    num1 = int(input("Ingrese numero 1: "))
    num2 = int(input("Ingrese numero 2: "))

    print("Suma: ", (num1+num2))
    print("Resta: ", (num1-num2))
    print("Multiplicacion: ", (num1*num2))
    print("Division: ", (num1/num2))

import math #importando libreria math

def ejer4():
    num = float(input("Ingrese numero decimal: "))

    raiz = math.sqrt(num)
    redo = round(num,2)
    cubo = math.pow(num,3)
    cubica = num ** (1/3)

    print("Raiz cuadrada: ",raiz)
    print("Redondeado: ",redo)
    print("Al cubo: ",cubo)
    print("Raiz cubica: ",cubica)

def ejer5():
    num = input("Ingrese un numero: ")

    entero = int(num)
    decim = float(num)

    print("Resto: ", (entero%2))
    print("Resto: ", (decim/3))

def ejer6():

    lado1 = int(input("Ingrese lado 1: "))
    lado2 = int(input("Ingrese lado 2: "))
    lado3 = int(input("Ingrese lado 3: "))

    if lado1==  lado2== lado3:
        print("Triangulo equilatero")
    elif lado1==lado2 or lado2 == lado3 or lado1 == lado3:
        print("Triangulo isosceles")
    else:
        print("Triangulo escaleno")


def ejer7():

    n=int(input("Ingrese un numero: "))
    suma = 0;

    for i in range(1,n+1):
        print(i)

        if(i%2 ==0):
            suma += i

    print("\nSuma de pares: ",suma)

def ejer8():

    cant = int(input("Ingrese la cantidad numeros: "))
    pares = impares = ceros =0
    for i in range(1, cant +1):
        num = int(input(f"Ingrese numero {i}: "))

        if num ==0:
            ceros+=1 # ceross++
        elif num%2 == 0:
            pares+=1
        else:
            impares += 1

    print("\n# pares: ",pares)
    print("# Impares: ",impares)
    print("# ceros: ", ceros)

ejer8()
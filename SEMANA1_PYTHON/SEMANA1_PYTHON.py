from networkx import node_clique_number


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

ejer4()
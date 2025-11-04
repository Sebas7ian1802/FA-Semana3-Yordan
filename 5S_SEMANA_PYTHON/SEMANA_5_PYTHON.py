def ejer1():

    edad = int(input("Ingrese la edad: "))

    if edad >=18:
         print("Elegible para votar")

         if edad >=25:
               print("Elegible para ser candidato")
         else:
               print("No es elegible para ser candidato")
    else:
        print("No es elegible para votar")

def ejer2():

    lado1 = int(input("Ingrese lado 1: "))
    lado2 = int(input("Ingrese lado 2: "))
    lado3 = int(input("Ingrese lado 3: "))

    if lado1==  lado2== lado3:
        print("Triangulo equilatero")
    elif lado1==lado2 or lado2 == lado3 or lado1 == lado3:
        print("Triangulo isosceles")
    else:
        print("Triangulo escaleno")

def ejer3():

    n=int(input("Ingrese un numero: "))
    suma = 0;

    for i in range(1,n+1):
        print(i)

        if(i%2 ==0):
            suma += i

    print("\nSuma de pares: ",suma)

def ejer4():

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

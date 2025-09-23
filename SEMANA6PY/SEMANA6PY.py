def ejer1():
    num = int(input("Ingrese numero de la tabla: "))

    while num <= 0:
        num = int(input())

    i=1
    print()
    while i <=12:
        print(f"{num} x {i} = {num*i}")
        i+=1
        print()
        while i <=12:
             print(f"{num} x {i} = {num*i}")
             i+=1


def ejer2():
    while True:
        num = int(input("Ingrese numero positivo (0 salir): "))

        if num < 0:
            print("Numero ivalido. Ingrese numero positivo")
            continue
        if (num == 0):
            break
        if num%2 ==0:
            sumaP += num;
        else:
            sumaI += num;

print ("\nSuma de pres: ", sumaP")
print ("Suma de impares: ", sumaI")

ejer2()

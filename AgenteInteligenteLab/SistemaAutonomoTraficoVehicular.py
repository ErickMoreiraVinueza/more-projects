import sys #Libreria para terminar el programa en caso de que se ingrese una respuesta incorrecta
#INSTRUCCIONES
#INGRESAR ubicación con la letra A/B/C/D mayúscula que se refiere a que se encuentra en una carretera o en la otra
#INGRESAR estado con los números 0/1 donde 0 significa Despejado y 1 siginifica tráfico

"""
La función menu_Instrucciones() es una función para presentar el menú e instrucciones principales del programa.
Parametos:
----------
No tiene parametros de entrada 

Retorna:
--------
No retorna ningún valor
"""

def menu_Instrucciones():
    print("------------Bienvenido al Sistema Automatizado de Tráfico Vehicular (SATV)------------")
    print("*INSTRUCCIONES*")
    print("Ingresar ubicación del vehículo con la letra A/B/C/D mayúscula, que se refiere a que se encuentra en una carretera o en la otra.")
    print("Ingresar estado de la carretera con los números 0/1 donde 0 significa despejado y 1 siginifica tráfico.")

"""
La función agente_vehicular() es un procedimiento para emular el funcionamiento de un sistema automatizado de tráfico.
Parametos:
----------
No tiene parametros de entrada 

Retorna:
--------
No retorna ningún valor
"""

def agente_vehicular_automatizado():
    # Se inicializa el estado objetivo dentro de un diccionario
    # 0 significa Despejado y 1 siginifica tráfico 
    estado_objetivo = {'A': '0', 'B': '0', 'C': '0', 'D': '0'}

    #Se inicializa variable costo 
    costo = 0

    #Se saca el tamaño del estado objetivo para utilizarlo en mi ciclo for como rango de las carreteras disponibles
    tamanio_estado_objetivo = len(estado_objetivo)

    #Se imprime en pantalla el mensaje del estado objetivo convertido en string, que quiere decir que se busca que el tráfico esté despejado.
    print("Estado objetivo, carreteras despejadas:" + str(estado_objetivo))

    for i in range(tamanio_estado_objetivo):
        #Se pide ingresar por teclado la ubicación del vehículo como se mencionó con las letras A/B/C/D mayúsculas.
        ubicacion = input("Ingrese la ubicación del vehículo: ") #Se almacena la ubicación


        #Condicion en caso de que ingrese una carretera incorrecta, termina el programa
        if ubicacion not in estado_objetivo:
            print('Por favor, ingrese una carretera permitida.')
            sys.exit()

        #Primera condición para la ubicación D en carretera.
        elif ubicacion == 'D':
            print("El auto se encuentra en la carretera --->",ubicacion)
            #Se pide ingresar por teclado el estado como se mencionó con los números 0/1 dependiendo si está despejado o hay tráfico
            print("Ingrese el estado de la carretera",ubicacion,":")
            estado = input() #Se almacena según si la ubicación está despejada o hay tráfico
            #Segunda condición que quiere decir que hay tráfico
            if estado == '1':
                print("En la carretera",ubicacion,'hay tráfico')
                print("Vehículo utilizando la última carretera disponible, no existen otras alternativas.")
                #Se termina el programa dado que se está utilizando la última carretera disponible
                break
            #Tercera condición que quiere decir que está despejado
            elif estado == '0':
                print("En la carretera",ubicacion,'no hay tráfico.')
                print('Continuando por la carretera',ubicacion)
                print("Vehículo utilizando la última carretera disponible, no existen otras alternativas.")
                #Se cambia el valor de carretera D a 0 dado que no hay tráfico por esa carretera
                estado_objetivo['D'] = '0'
                #Se termina el programa dado que se está utilizando la última carretera disponible y además no hay tráfico, logrando el objetivo
                break
            #Condicion en caso de que ingrese un estado incorrecto, termina el programa
            elif estado != 1 or estado !=0:
                print('Por favor, ingrese un estado correcto.')
                sys.exit()

        #Cuarta condición para la ubicación A,B o C en carretera.
        elif ubicacion == 'A' or 'B' or 'C':
            print("El auto se encuentra en la carretera --->",ubicacion)
            #Se pide ingresar por teclado el estado como se mencionó con los números 0/1 dependiendo si está despejado o hay tráfico
            print("Ingrese el estado de la carretera",ubicacion,":")
            estado = input() #Se almacena según si la ubicación está despejada o hay tráfico
            #Quinta condición que quiere decir que hay tráfico.
            if estado == '1':
                print("En la carretera",ubicacion,'hay tráfico')
                print("Evitando la carretera",ubicacion)
                costo += 1 #Se incrementa el costo en 1
                #Se imprime el costo convertido en String
                print("Costo actual:",str(costo),"$")
                print("Vehículo moviéndose a la siguiente carretera")
                #Se deja pasar para preguntar la siguiente carretera a la que el vehículo desea moverse
                pass
            #Sexta condición que quiere decir que está despejado
            elif estado == '0':
                print("En la carretera",ubicacion,'no hay tráfico')
                print('Continuando por la carretera',ubicacion)
                #Se cambia el valor de carretera A a 0 dado que no hay tráfico por esa carretera
                estado_objetivo[ubicacion] = '0'
                #Se termina el programa dado que en la carretera no hay tráfico, logrando el objetivo
                break
            #Condicion en caso de que ingrese un estado incorrecto, termina el programa
            elif estado != 1 or estado !=0:
                print('Por favor, ingrese un estado correcto.')
                sys.exit()

    #Se imprime el costo y se da las gracias por usar el sistema.
    print("Medición de desempeño: " + str(costo),"$")
    print("Gracias por usar el Sistema Automatizado de Tráfico Vehicular (SATV) :D")

#If main de nuestro programa donde llamo a las funciones correspondientes.
if __name__  == '__main__':
    menu_Instrucciones()
    agente_vehicular_automatizado()
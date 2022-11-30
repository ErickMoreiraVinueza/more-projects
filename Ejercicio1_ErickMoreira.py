#Libreria que me permite graficar en python 
from turtle import *

"""
Realizamos una función sencilla para adornar una bienvenida al programa. 
"""
def bienvenida():
    print('\n')
    print('*' * 65)
    print('*Te doy la bienvenida al juego Advina el numero de cuadradros :D*')
    print('*' * 65)
    print('\n')

"""
Realizamos una función sencilla para adornar una despedida al programa. 
"""
def despedida():
    print('\n')
    print('*' * 71)
    print('* Gracias por jugar al Adivina el numero de cuadrados. ¡Hasta pronto! *')
    print('*' * 71)
    print('\n')

"""
Realizamos una función sencilla para volver a ejecutar el programa o no, dependiendo de la decisión del usuario. 
"""
def jugar_otra_vez():
    return input('\nDeseas jugar otra vez (introduce s para sí o cualquier otra cosa para no): ')

"""
Encerramos el comportamiento de los cuadrados para elaborarlos respectivamente en dos funciones. 
"""
def cuadrado_catorce(longitud):
    # Cuatro veces...
    for i in range(4):
        speed(0) #Velocidad a la que grafica la figura, podemos cambiarla para que sea mas rápida o mas lenta.
        # Ir hacia adelante
        forward(longitud)
        # Y girar 90 grados
        right(90)
        for i in range(4):
            # Ir hacia adelante
            forward(longitud*2)
            # Y girar 90 grados
            right(90)

def cuadrado_cinco(longitud):
    # Cuatro veces...
    for i in range(4):
        speed(0) 
        # Ir hacia adelante
        forward(longitud*2)
        # Y girar 90 grados
        right(90)
        # Cuatro veces...
        for i in range(4):
            # Ir hacia adelante
            forward(longitud)
            # Y girar 90 grados
            right(90)

#Main para la ejecucion principal del programa.
if __name__ == '__main__':
#Ciclo do-while para ejecutar el programa y utilizar la función jugar_otra_vez dependiendo de la decisión del usuario. 
    while True: 
        reset() #Limpia las graficas de la pantalla.
        bienvenida()
        cuadrado_catorce(50)
        print('¿Cuantos cuadrados hay?')
        respuesta = input()
        if int(respuesta) == 14:
            print('\nCorrecto!, siga al siguiente nivel')
            print('\n-----Revise el nuevo cuadrado-----')
            reset()
            cuadrado_cinco(50)
            print('\nCuantos cuadrados hay?')
            respuesta2 = input()
            if int(respuesta2) == 5:
                print('\nCorrecto!, ha ganado el juego :D')
                despedida()
                exit()
        else:
            print('\nIncorrecto!')
            print('\nVuelva a intentarlo, suerte!')
            if jugar_otra_vez() != 's': break
    despedida()

#Librería que me permite usar el método sys.exit() para terminar el programa
import sys
def menuVelocidad():
    """"
    Se crea la función del menú para el cálculo de la velocidad, se ejecutará correspondiente a la opción que elija el usuario para que
    así sea de manera genérica.
  
    Parámetros:
    -------------------
    No recibe ningún parámetro.

    Retorna:
    -------------------
    Retorna la variable opción que ha eligido el usuario.
    """
    #Menú principal que me permite elegir una opción de conversión según la necesidad del usuario.
    print('-----Bienvenido al Cálculo de velocidad------')
    print("OJO: El programa muestra el resultado final en las unidades referentes al Sistema Internacional, es decir m/s")
    print('1.Trabajar con desplazamiento en metros y tiempo en segundos')
    print('2.Trabajar con desplazamiento en kilómetros y tiempo en horas')
    print('Elija la opción que desee: ')
    #Guardo la opción correspondiente.
    opcion = int(input())
    return opcion

def calcularVelocidad(opcion):
    """"
    Se crea la función que hará el cálculo de la velocidad según los datos que haya elegido el usuario para trabajar.
  
    Parámetros:
    -------------------
    Recibe la variable opción que digitó el usuario para procesarla.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    #Condicionales para realizar el cálculo según la opción que haya digitado el usuario.
    if(opcion == 1):
        print('Ingrese el valor del desplazamiento en metros:')
        #Guardo el valor ingresado en metros.
        desplazamiento = float(input())
        print('Ingrese el valor del tiempo en segundos:')
        #Guardo el valor ingresado en segundos.
        tiempo = float(input())
        #Condicional para evitar el ingreso de un tiempo negativo, ya que eso no es posible.
        if(tiempo < 0):
            print('No existe un valor negativo para el tiempo, intente nuevamente')
            sys.exit()
        #Realizo el cálculo de la velocidad.
        velocidad = desplazamiento/tiempo
        #Condicionales para mostrar velocidades negativas o positivas según sea el caso.
        if(velocidad < 0):
            #Imprimo la velocidad redondeada a dos decimales con el método round.
            print('La velocidad es: ',round(velocidad,2),' m/s a la izquierda')
        elif(velocidad > 0):
            #Imprimo la velocidad redondeada a dos decimales con el método round.
            print('La velocidad es ',round(velocidad,2),' m/s a la derecha')
    
    elif(opcion == 2):
        print('Ingrese el valor del desplazamiento en kilómetros:')
        #Guardo el valor ingresado en kilómetros.
        desplazamiento = float(input())
        print('Ingrese el valor del tiempo en horas:')
        #Guardo el valor ingresado en horas.
        tiempo = float(input())
        #Condicional para evitar el ingreso de un tiempo negativo, ya que eso no es posible.
        if(tiempo < 0):
            print('No existe un valor negativo para el tiempo, intente nuevamente')
            sys.exit()
        #Realizo el cálculo de la velocidad.
        velocidad = desplazamiento/tiempo
        #Realizo la conversión de datos de km/h a m/s.
        conversor = velocidad * (18/5)
        #Condicionales para mostrar velocidades negativas o positivas según sea el caso.
        if(conversor < 0):
            #Imprimo la velocidad redondeada a dos decimales con el método round.
            print('La velocidad es: ',round(conversor,2),' m/s a la izquierda')
        elif(conversor > 0):
            #Imprimo la velocidad redondeada a dos decimales con el método round.
            print('La velocidad es ',round(conversor,2),' m/s a la derecha')
    #Condicional que me permite controlar que el usuario elija una opción correcta.
    elif(opcion > 2 or opcion < 1):
        print('Elija una opción correcta por favor, vuelva a intentarlo')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    opcion = menuVelocidad()
    calcularVelocidad(opcion)
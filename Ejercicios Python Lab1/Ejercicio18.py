def menuConversor():
    """"
    Se crea la función del menú para la conversión de temperaturas, se ejecutará correspondiente a la opción que elija el usuario 
    para que así sea de manera genérica.
  
    Parámetros:
    -------------------
    No recibe ningún parámetro.

    Retorna:
    -------------------
    Retorna la variable opción que ha eligido el usuario.
    """
    #Menú principal que me permite elegir una opción de conversión según la necesidad del usuario.
    print('-----Bienvenido al Conversor de temperaturas------')
    print('1.Convertir celsius a fahrenheit y kelvin')
    print('2.Convertir farenheit a celsius y kelvin')
    print('3.Convertir kelvin a celsius y fahrenheit')
    print('Elija la opción que desee: ')
    #Guardo la opción correspondiente.
    opcion = int(input())
    return opcion

def conversorTemperaturas(opcion):
    """"
    Se crea la función que hará la conversión de temperaturas según la opción que haya elegido el usuario.
  
    Parámetros:
    -------------------
    Recibe la variable opción que digitó el usuario para procesarla.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    #Condicionales para realizar la conversión según la opción que haya digitado el usuario.
    if(opcion == 1):
        print('Ingrese el valor en celsius:')
        #Guardo el valor ingresado en celsius.
        temperatura1 = float(input())
        #Realizo la conversión tanto en fahrenheit como en kelvin.
        temperatura2 = (temperatura1*9/5) + 32
        temperatura3 = temperatura1 + 273.15
        #Imprimo las conversiones.
        print('El valor en fahrenheit es aproximadamente:',temperatura2)
        print('El valor en kelvin es aproximadamente:',temperatura3)
    elif(opcion == 2):
        print('Ingrese el valor en fahrenheit:')
        #Guardo el valor ingresado en fahrenheit.
        temperatura1 = float(input())
        #Realizo la conversión tanto en celsius como en kelvin.
        temperatura2 = (temperatura1-32) * 5/9
        temperatura3 = (temperatura1-32) * 5/9 + 273.15
        #Imprimo las conversiones.
        print('El valor en celsius es aproximadamente:',temperatura2)
        print('El valor en kelvin es aproximadamente:',temperatura3)
    elif(opcion == 3):
        print('Ingrese el valor en kelvin:')
        #Guardo el valor ingresado en kelvin.
        temperatura1 = float(input())
        #Realizo la conversión tanto en celsius como en fahrenheit.
        temperatura2 = temperatura1-273.15
        temperatura3 = (temperatura1-273.15) * 9/5 + 32
        #Imprimo las conversiones.
        print('El valor en celsius es aproximadamente:',temperatura2)
        print('El valor en fahrenheit es aproximadamente:',temperatura3)
    #Condicional que me permite controlar que el usuario elija una opción correcta.
    elif(opcion > 3 or opcion < 1):
        print('Elija una opción correcta por favor, vuelva a intentarlo')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    opcion = menuConversor()
    conversorTemperaturas(opcion)
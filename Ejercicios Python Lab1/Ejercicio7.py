def menuConversor():
    """"
    Se crea la función del menú para la conversión de medidas, se ejecutará correspondiente a la opción que elija el usuario para que
    así sea de manera genérica.
  
    Parámetros:
    -------------------
    No recibe ningún parámetro.

    Retorna:
    -------------------
    Retorna la variable opción que ha eligido el usuario.
    """
    #Menú principal que me permite elegir una opción de conversión según la necesidad del usuario.
    print('-----Bienvenido al Conversor de pesos------')
    print('1.Convertir centímetros a metros y kilómetros')
    print('2.Convertir metros a centímetros y kilómetros')
    print('3.Convertir kilómetros a centímetros y metros')
    print('Elija la opción que desee: ')
    #Guardo la opción correspondiente.
    opcion = int(input())
    return opcion

def conversorMedidas(opcion):
    """"
    Se crea la función que hará la conversión de medidas según la opción que haya elegido el usuario.
  
    Parámetros:
    -------------------
    Recibe la variable opción que digitó el usuario para procesarla.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    #Condicionales para realizar la conversión según la opción que haya digitado el usuario.
    if(opcion == 1):
        print('Ingrese el valor en centímetros:')
        #Guardo el valor ingresado en centímetros.
        unidad1 = float(input())
        #Realizo la conversión tanto en metros como en kilómetros.
        unidad2 = unidad1/100
        unidad3 = unidad1/100000
        #Imprimo las conversiones.
        print('La medida en metros es aproximadamente:',unidad2)
        print('La medida en kilómetros es aproximadamente:',unidad3)
    elif(opcion == 2):
        print('Ingrese el valor en metros:')
        #Guardo el valor ingresado en metros.
        unidad1 = float(input())
        #Realizo la conversión tanto en centímetros como en kilómetros.
        unidad2 = unidad1*100
        unidad3 = unidad1/1000
        #Imprimo las conversiones.
        print('La medida en centímetros es aproximadamente:',unidad2)
        print('La medida en kilómetros es aproximadamente:',unidad3)
    elif(opcion == 3):
        print('Ingrese el valor en kilómetros:')
        #Guardo el valor ingresado en kilómetros.
        unidad1 = float(input())
        #Realizo la conversión tanto en centímetros como en metros.
        unidad2 = unidad1*100000
        unidad3= unidad1*1000
        #Imprimo las conversiones.
        print('La medida en centímetros es aproximadamente:',unidad2)
        print('La medida en metros es aproximadamente:',unidad3)
    #Condicional que me permite controlar que el usuario elija una opción correcta.
    elif(opcion > 3 or opcion < 1):
        print('Elija una opción correcta por favor, vuelva a intentarlo')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    opcion = menuConversor()
    conversorMedidas(opcion)
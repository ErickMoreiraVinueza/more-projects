def menuConversor():
    """"
    Se crea la función del menú para la conversión de pesos, se ejecutará correspondiente a la opción que elija el usuario para que
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
    print('1.Convertir libras a kilos y gramos')
    print('2.Convertir kilos a libras y gramos')
    print('3.Convertir gramos a libras y kilos')
    print('Elija la opción que desee: ')
    #Guardo la opción correspondiente.
    opcion = int(input())
    return opcion

def conversorPesos(opcion):
    """"
    Se crea la función que hará la conversión de pesos según la opción que haya elegido el usuario.
  
    Parámetros:
    -------------------
    Recibe la variable opción que digitó el usuario para procesarla.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    #Condicionales para realizar la conversión según la opción que haya digitado el usuario.
    if(opcion == 1):
        print('Ingrese el valor en libras:')
        #Guardo el valor ingresado en libras.
        unidad1 = float(input())
        #Realizo la conversión tanto en kilos como en gramos.
        unidad2 = unidad1/2.205
        unidad3 = unidad1*453.6
        #Imprimo las conversiones redondeadas a dos decimales con el método round.
        print('El peso en kilos es aproximadamente:',round(unidad2,2))
        print('El peso en gramos es aproximadamente:',round(unidad3,2))
    elif(opcion == 2):
        print('Ingrese el valor en kilos:')
        #Guardo el valor ingresado en kilos.
        unidad1 = float(input())
        #Realizo la conversión tanto en libras como en gramos.
        unidad2 = unidad1*2.205
        unidad3 = unidad1*1000
        #Imprimo las conversiones redondeadas a dos decimales con el método round.
        print('El peso en libras es aproximadamente:',round(unidad2,2))
        print('El peso en gramos es aproximadamente:',round(unidad3,2))
    elif(opcion == 3):
        print('Ingrese el valor en gramos:')
        #Guardo el valor ingresado en gramos.
        unidad1 = float(input())
        #Realizo la conversión tanto en libras como en kilos.
        unidad2 = unidad1/453.6
        unidad3= unidad1/1000
        #Imprimo las conversiones redondeadas a dos decimales con el método round.
        print('El peso en libras es aproximadamente:',round(unidad2,2))
        print('El peso en kilos es aproximadamente:',round(unidad3,2))
    #Condicional que me permite controlar que el usuario elija una opción correcta.
    elif(opcion > 3 or opcion < 1):
        print('Elija una opción correcta por favor, vuelva a intentarlo')
    
#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    opcion = menuConversor()
    conversorPesos(opcion)
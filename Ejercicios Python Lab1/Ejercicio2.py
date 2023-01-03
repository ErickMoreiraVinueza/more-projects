def menuConversor():
    """"
    Se crea la función del menú para la conversión de monedas, se ejecutará correspondiente a la opción que elija el usuario para que
    así sea de manera genérica.
  
    Parámetros:
    -------------------
    No recibe ningún parámetro.

    Retorna:
    -------------------
    Retorna la variable opción que ha eligido el usuario.
    """
    #Menú principal que me permite elegir una opción de conversión según la necesidad del usuario.
    print('-----Bienvenido al Conversor de monedas------')
    print('1.Convertir RMB a dólares y pesos colombianos')
    print('2.Convertir dólares a RMB y pesos colombianos')
    print('3.Convertir pesos colombianos a RMB y dólares')
    print('Elija la opción que desee: ')
    #Guardo la opción correspondiente.
    opcion = int(input())
    return opcion

def conversorMonedas(opcion):
    """"
    Se crea la función que hará la conversión de monedas según la opción que haya elegido el usuario.
  
    Parámetros:
    -------------------
    Recibe la variable opción que digitó el usuario para procesarla.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    #Condicionales para realizar la conversión según la opción que haya digitado el usuario.
    if(opcion == 1):
        print('Ingrese el valor en RMB:')
        #Guardo el valor ingresado en RMB.
        moneda1 = float(input())
        #Realizo la conversión tanto en dólares como en pesos colombianos.
        moneda2 = moneda1*0.14472256
        moneda3 = moneda1*707.96257
        #Imprimo las conversiones redondeadas a dos decimales con el método round.
        print('El valor en dólares es aproximadamente:',round(moneda2,2))
        print('El valor en pesos colombianos es aproximadamente:',round(moneda3,2))
    elif(opcion == 2):
        print('Ingrese el valor en dólares:')
        #Guardo el valor ingresado en dólares.
        moneda1 = float(input())
        #Realizo la conversión tanto en RMB como en pesos colombianos.
        moneda2 = moneda1*6.913042
        moneda3 = moneda1*4893.0558
        #Imprimo las conversiones redondeadas a dos decimales con el método round.
        print('El valor en RMB es aproximadamente:',round(moneda2,2))
        print('El valor en pesos colombianos es aproximadamente:',round(moneda3,2))
    elif(opcion == 3):
        print('Ingrese el valor en pesos colombianos:')
        #Guardo el valor ingresado en RMB.
        moneda1 = float(input())
        #Realizo la conversión tanto en RMB como en dólares.
        moneda2 = moneda1*0.0014125267
        moneda3 = moneda1*0.00020431522
        #Imprimo las conversiones redondeadas a dos decimales con el método round.
        print('El valor en RMB es aproximadamente:',round(moneda2,2))
        print('El valor en dólares es aproximadamente:',round(moneda3,2))
    #Condicional que me permite controlar que el usuario elija una opción correcta.
    elif(opcion > 3 or opcion < 1):
        print('Elija una opción correcta por favor, vuelva a intentarlo')
        
#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    opcion = menuConversor()
    conversorMonedas(opcion)
def leerVariables():
    """"
    Se crea la función para la lectura de las horas trabajadas y el costo $ por hora de la cantidad de trabajadores que así decida el 
    usuario para que sea de manera genérica.
  
    Parámetros:
    -------------------
    No recibe ningún valor.

    Retorna:
    -------------------
    No retorna ningún valor dado que solo tengo que leer los datos del usuario
    """
    #Solicito al usuario el número de trabajadores para los que desea ingresar los datos.
    num_personas = int(input('Ingrese el número de  personas para los que desea ingresar los nombres: '))
    #Genero una condición if para asegurarme que al menos debe ingresar los datos de un trabajador, y para que no permita ingresar 
    #números negativos dado que eso no tendría sentido.
    if(num_personas >= 1):
        #Genero mi ciclo for que es el encargado de ir pidiendo los datos correspondientes, donde este se va a detener hasta el número
        #de trabajadores que haya digitado el usuario.
        for i in range(0,num_personas):
            #Solicito el número de horas trabajadas por el trabajador.
            print('\nIngrese el nombre de la persona #',i+1,':')
            nombre = input()
            print('Hola',nombre,'!')
    #Con el elif controlo que no se permita el ingreso de números negativos, y si es el caso, imprimo un mensaje para que lo intente
    #nuevamente.
    elif(num_personas <= 0):
        print('Lo que está diciendo no tiene sentido, intente nuevamente')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    leerVariables() 
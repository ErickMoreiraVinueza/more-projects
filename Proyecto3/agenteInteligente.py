def validarBebida(bebida, bebidasValidas):
    """
    Funcion que valida el ingreso de una bebida por parte del usuario

    Parámetros:
    ---------------------
    bebida (str): bebida que debe ser ingresada
    bebidasValidas (list): conjunto de bebidas que puede ingresar el usuario

    Retorna:
    --------------------
    Retorna un valor booleano
    """
    #La función .lower() hace que lo ingresado este explícitamente en minúsculas
    #Si la bebida no se encuentra en la lista de bebidas disponibles
    if bebida.lower() not in bebidasValidas:
        #Se le dice al usuario que la bebida no es válida
        print("La bebida ingresada no es válida.")
        return False
    else:
        #Caso contrario avanza
        return True

def validarEstado(estado):
    """
    Funcion que valida que el estado ingresado por el usuario sea "frio" o "caliente".

    Parámetros:
    ------------------------
    estado (str): ingreso del estado de la bebida por parte del usuario

    Retorna:
    ------------------------
    Retorna un valor booleano
    """
    #La función .lower() hace que lo ingresado este explícitamente en minúsculas
    #Condicion que establece que lo unico ingresado por el usuario debe ser 'frio' o 'caliente'
    if estado.lower() != "frio" and estado.lower() != "caliente":
        #En caso de no ser así se muestra al usuario el mensaje que el estado no es valido
        print("El estado ingresado no es válido.")
        return False
    #Caso contrario se avanza con la ejecución
    else:
        return True

def calentarBebida(bebida, estado, bebidasEstado, costo):
    """
    Funcion que calienta o enfría la bebida según su estado actual.
    
    Parámetros:
    ----------------------
    bebida (str): bebida ingresada por el usuario
    estado (str): estado ingresado por el usuario
    bebidasEstado (dicc): diccionario donde se alamcenará todas las acciones

    Retorna:
    ----------------------
    No retorna nada en específico
    """
    #Condición si el estado es frío
    if estado == "frio":
        #Se muestra al usuario que la bebida se está calentando
        print("Calentando la bebida...")
        #Se ha calentado la bebida
        print("La bebida está caliente.")
        #Se agrega la bebida y el estado actual al diccionario
        bebidasEstado[bebida.lower()] = "caliente"
    else:
        #caso contrario como la bebida está caliente, se enfriará
        print("Enfriando la bebida...")
        #Se ha enfriado la bebida
        print("La bebida está fría.")
        #Se agrega la bebida y el estado actual al diccionario
        bebidasEstado[bebida.lower()] = "frio"
    return costo

def mostrarBebidas(bebidasEstado):
    """
    Función que muestra el estado actual de todas las bebidas en el diccionario.

    Parámetros:
    -------------------
    bebidasEstado (dicc): Diccionario donde se alamacena las acciones con cada bebida
    """
    print("Estado actual de las bebidas:")
    #Bucle para imprimir cada bebida con su estado dentro del diccionario creado
    for bebida, estado in bebidasEstado.items():
        #Se imprimen las bebidas con su estado actual respectivo
        print(f"{bebida.capitalize()}: {estado}")

#Funcion main donde se ejecutará todo el programa
if __name__ == "__main__":
    costo = 0
    #Lista de bebidas validas para el ingreso
    bebidasValidas = ["agua", "cafe", "te", "gaseosa", "jugo", "yogurt", "leche", "cerveza", "vino"]
    #Se inicia un diccionario vacio para almacenar la información
    bebidasEstado = {}
    #Se pide al usuario que ingrese el tipo de bebida
    print('El agente inteligente puede trabajar con los siguientes tipos de bebida')
    print(bebidasValidas)
    bebida = input("Ingrese el tipo de bebida (o escriba 'salir' para terminar): ")
    #Bucle que seguirá pidiendo la bebida al usuario hasta que escriba 'salir'
    while bebida.lower() != "salir":
        #Se la función para validar la bebida
        if validarBebida(bebida, bebidasValidas):
            #Guardar la bebida en el diccionario con estado desconocido
            bebidasEstado[bebida.lower()] = "desconocido"           
            #Pedir al usuario que ingrese el estado actual de la bebida
            estado = input("Ingrese el estado actual de la bebida (frio o caliente): ")            
            if validarEstado(estado):
                #Actualizar el estado de la bebida en el diccionario una vez ya haya sido calentada o enfriada
                costoTotal = calentarBebida(bebida, estado, bebidasEstado, costo)            
        #Se pide al usuario que ingrese una nueva bebida o si desea salir
        print('Recuerde que solo tenemos este tipo de bebidas disponibles')
        print(bebidasValidas)
        bebida = input("Ingrese otro tipo de bebida (o escriba 'salir' para terminar): ")
    #Se mostrará el estado actual de todas las bebidas en el diccionario
    mostrarBebidas(bebidasEstado)
    print('Costo total por las acciones realizadas:', len(bebidasEstado))

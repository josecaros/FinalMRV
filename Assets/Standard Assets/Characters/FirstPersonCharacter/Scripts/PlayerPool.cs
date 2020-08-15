using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerPool : MonoBehaviour
{
    // Componentes iniciales, es la primera funcion que se ejecuta
    public abstract void Start();

    // Actualiza el entorno cuando es llamado
    public abstract void Update();

    // Obtiene las entradas del Teclado
    public abstract void GetInput( out float speed);
}

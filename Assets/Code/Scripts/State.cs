using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Es un atributo de la clase que nos permite crear ScriptableObjects de tipo
//State desde la ventana del Project
[CreateAssetMenu(menuName = "State")]
//Esta clase deriva ahora de los ScriptableObjects
public class State : ScriptableObject
{
    //Genero un campo de strings, con un tamaño específico
    //[TextArea(,)] -> atributo que permite crear un cuadro de texto con la cantidad de líneas escalable
    //[SerializeField] -> atributo que permite que una variable o referencia siga siendo privada pero accesible desde el editor de Unity
    [TextArea(14, 10)] [SerializeField] string storyText;

}

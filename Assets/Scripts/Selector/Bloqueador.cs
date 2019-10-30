//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Bloqueador : MonoBehaviour
//{
//    private DropDownController drop;
//    private Dropdown _dropdown;

//    private void Start()
//    {
//        drop = GetComponent<DropDownController>();
//        _dropdown = GetComponent<Dropdown>();
//    }
//    public void Bloquear()
//    {

//        switch (value)
//        {
//            case 0:
//                //Posicion
//                drop.indexesToDisable.Add(1);
//                drop.indexesToDisable.Add(2);
//                if (_dropdown.value == 1 || _dropdown.value == 2)
//                    _dropdown.value = 0;

//                //consistencia
//                drop.indexesToDisable.Add(1);
//                drop.indexesToDisable.Add(2);
//                if (_dropdown.value == 1 || _dropdown.value == 2)
//                    _dropdown.value = 0;

//                //borramiento
//                drop.indexesToDisable.Add(1);
//                drop.indexesToDisable.Add(2);
//                if (_dropdown.value == 1 || _dropdown.value == 2)
//                    _dropdown.value = 0;
//                break;
//            case 1:
//                //posicion
//                drop.indexesToDisable.Add(2);
//                if (_dropdown.value == 2)
//                    _dropdown.value = 0;

//                //consistencia
//                drop.indexesToDisable.Add(2);
//                if (_dropdown.value == 2)
//                    _dropdown.value = 0;

//                //borramiento
//                drop.indexesToDisable.Add(2);
//                if (_dropdown.value == 2)
//                    _dropdown.value = 0;
//                break;
//            case 2:
//                break;
//            case 3:
//                //posicion
//                drop.indexesToDisable.Add(0);
//                drop.indexesToDisable.Add(1);
//                if (_dropdown.value == 0 || _dropdown.value == 1)
//                    _dropdown.value = 2;

//                //consistencia
//                drop.indexesToDisable.Add(0);
//                if (_dropdown.value == 0)
//                    _dropdown.value = 2;

//                //borramiento
//                drop.indexesToDisable.Add(0);
//                if (_dropdown.value == 0)
//                    _dropdown.value = 2;
//                break;
//        }
//    }
//}

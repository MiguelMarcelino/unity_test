using System.Collections;
using UnityEngine;

public class SerializedAttributes99 : MonoBehaviour
{
    [SerializeField] // correct usage
    private string privateField2;

    [SerializeField] // redundant usage
    public string publicField2;

    [SerializeField] // invalid usage 1
    private string PrivateProperty { get; set; }

    [SerializeField] // invalid usage 2
    static string staticField;

    [SerializeField] // invalid usage 
    readonly field readonlyField;
}
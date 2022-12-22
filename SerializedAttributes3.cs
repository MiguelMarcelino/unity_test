using System.Collections;
using UnityEngine;

public class SerializedAttributes2 : MonoBehaviour
{
    [SerializeField] // correct usage
    private string privateField2;

    [SerializeField] // redundant usage
    public string publicField2;

    [SerializeField]s
    private string PrivateProperty { get; set; }

    [SerializeField] // invalid usage
    static string staticField;

    [SerializeField] // invalid usage
    readonly field readonlyField;
}
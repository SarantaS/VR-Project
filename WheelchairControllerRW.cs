    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using VRTK.Controllables;

public class WheelchairControllerRW : MonoBehaviour
{
    public VRTK_BaseControllable controllable;
    public GameObject wheelchair;
    public GameObject pivotPoint;
    public float speed;
    private float nr;
    private float or;
    private int direction = 0;

    private void Update()
    {
        if (or < nr)
        {
            direction = 1;
        }
        if (or > nr)
        {
            direction = -1;
        }
        or = nr;
    }
    private void LateUpdate()
    {
        nr = controllable.GetValue();
    }

    [System.Obsolete]
    protected virtual void OnEnable()
    {
        if (controllable != null)
        {
            controllable.ValueChanged += ValueChanged;
        }
    }

    [System.Obsolete]
    protected virtual void OnDisable()
    {
        if (controllable != null)
        {
            controllable.ValueChanged -= ValueChanged;
        }
    }

    [System.Obsolete]
    protected virtual void ValueChanged(object sender, ControllableEventArgs e)
    {
        if (wheelchair != null)
        {
            if (direction == 1)
            {
                wheelchair.transform.RotateAround(pivotPoint.transform.position, Vector3.up, -(speed * e.normalizedValue * Time.deltaTime));
                wheelchair.transform.Translate(Vector3.forward * (e.normalizedValue * Time.deltaTime));
            }
            else if (direction == -1)
            {
                wheelchair.transform.RotateAround(pivotPoint.transform.position, Vector3.up, (speed * e.normalizedValue * Time.deltaTime));
                wheelchair.transform.Translate(Vector3.forward * -(e.normalizedValue * Time.deltaTime));
            }
        }
    }
}


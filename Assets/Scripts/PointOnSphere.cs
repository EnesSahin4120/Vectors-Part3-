using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PointOnSphere : MonoBehaviour
{
    [SerializeField] private Text sphericalCoordinatesText;
    public LayerMask targetLayer;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, 100f, targetLayer))
            {
                transform.position = hit.point;
            }
        }

        Coordinates PointCoordinates = new Coordinates(transform.position);
        List<float> sphericalCoordinates = Mathematics.SphericalCoordinates(PointCoordinates);

        sphericalCoordinatesText.text = "SPHERICAL COORDINATES : (" + sphericalCoordinates[0].ToString() + "," + sphericalCoordinates[1].ToString() + "," + sphericalCoordinates[2] + ")";
    }
}

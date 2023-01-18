using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabScript : MonoBehaviour
{
    //[SerializeField] private LayerMask _layer;

    //private GameObject _grabbedObject;

    //[SerializeField] private float _grabDistance = 6.0f;
    //[SerializeField] private float _holdDistance = 4.0f;

    //void Update()
    //{

    //    //float zCoord = Camera.main.WorldToScreenPoint(_grabbedObject.transform.position).z;

    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        if(_grabbedObject != null)
    //        {
    //            Debug.Log("Dropped: " + _grabbedObject.name);
    //            _grabbedObject = null;
    //             return;
    //        }

    //        Debug.DrawRay(transform.position, transform.forward * _holdDistance, Color.green, 0.2f);


    //        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, _grabDistance, _layer))
    //        {
    //            if (hit.transform.parent != null)
    //                hit.transform.SetParent(null);

    //            _grabbedObject = hit.transform.gameObject;
    //            Debug.Log("Grabbed: " + hit.transform.name);
    //        }
    //    }

    //    if(_grabbedObject!= null)
    //    {
    //        _grabbedObject.transform.position = transform.position + transform.forward * _holdDistance;
    //    }
    //}

    [SerializeField] private SelectionManager _selectionManager;

    private IGrabbable _grabSelection;

    private void OnEnable()
    {
        _selectionManager.OnSelectionChanged += OnSelectionChanged;
    }

    private void OnDisable()
    {
        _selectionManager.OnSelectionChanged -= OnSelectionChanged;
    }

    private void OnSelectionChanged(Transform obj)
    {
        if (_grabSelection != default)
        {
            Debug.Log("Dropped: " + _selectionManager.name);
            _selectionManager = null;
            return;
        }
        if (obj && obj.TryGetComponent<IGrabbable>(out _grabSelection))
        {
            _selectionManager.transform.SetParent(null);


            float zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            _selectionManager.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zCoord));

        }
    }
}

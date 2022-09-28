using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] private Vector2[] points;

    public Vector2[] Points => points;
    public Vector2 CurrentPosition => _CurrentPosition;

    private Vector2 _CurrentPosition;
    private bool _GameStarted;

    private void Start()
    {
        _GameStarted = true;
        _CurrentPosition = transform.position;
    }

    public Vector2 GetWaypointPosition(int index)
    {
        return CurrentPosition + Points[index];
    }

    private void OnDrawGizmos()
    {
        if (!_GameStarted && transform.hasChanged)
        {
            _CurrentPosition = transform.position;
        }

        for (int i = 0; i < points.Length; i++)
        {
            Gizmos.color = Color.black;
            Gizmos.DrawWireSphere(points[i] + _CurrentPosition, 0.5f);

            if (i < points.Length - 1)
            {
                Gizmos.color = Color.gray;
                Gizmos.DrawLine(points[i] + _CurrentPosition, points[i + 1] + _CurrentPosition);    
            }
        }
    }

    /*[CustomEditor(typeof(Waypoint))]
    
    public class WaypointEditor : Editor
    {
        Waypoint Waypoint => target as Waypoint;
        private void OnSceneGUI()
        {
            Handles.color = Color.cyan;
            for (int i = 0; i < Waypoint.points.Length; i++)
            {
                EditorGUI.BeginChangeCheck();

                //Create Handles
                Vector2 currentWaypointPoint
            }
        }
    }*/
}

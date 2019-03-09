using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Line))]
public class LineEditor : Editor
{
    private void OnSceneGUI()
    {
        Line line = target as Line;
        if (line == null)
        {
            Debug.Log("Line editor==null");
            return;
        }
        //çizgi
        Transform lineTransform = line.transform;
        Vector3 p0 = lineTransform.TransformPoint(line.P0);
        Vector3 p1 = lineTransform.TransformPoint(line.P1);
        //rengi
        Handles.color = Color.red;
        //çizme
        Handles.DrawLine(p0, p1);
        Quaternion handleRotation = Quaternion.identity;
       
        //check p0
        EditorGUI.BeginChangeCheck();
        //yeni pozisyonu ayarla p0
        p0 = Handles.PositionHandle(p0, handleRotation);
        if (EditorGUI.EndChangeCheck())
        {
            //degişiklik geri alma
            Undo.RecordObject(line, "move_point");
            //güncelle p0
            line.P0 = lineTransform.InverseTransformPoint(p0);

        }
        //check p1
        EditorGUI.BeginChangeCheck();
        //yeni pozisyonu ayarla p1
        p1 = Handles.PositionHandle(p1, handleRotation);
        if (EditorGUI.EndChangeCheck())
        {
            //degişiklik geri alma
            Undo.RecordObject(line, "move_point");
            //güncelle p1
            line.P1 = lineTransform.InverseTransformPoint(p1);

        }
    }

}

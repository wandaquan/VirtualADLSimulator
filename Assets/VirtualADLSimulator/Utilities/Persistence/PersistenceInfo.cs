﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PersistenceInfo
{
    public int id;
    public string name;
    public PersistenceTransform persistenceTransform;
    public PersistenceMeshFilter persistenceMeshFilter;
    public PersistenceMeshRenderer persistenceMeshRenderer;
    public PersistenceCollider persistenceCollider;
    public List<MonoBehaviour> persistenceScripts;
}

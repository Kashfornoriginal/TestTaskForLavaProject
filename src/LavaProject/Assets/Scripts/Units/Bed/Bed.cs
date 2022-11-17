using UnityEngine;

public class Bed : MonoBehaviour
{
    private BedCellStaticData _bedCellStaticSata;

    private BedMeshHandler _bedMeshHandler;

    public BedCellStaticData BedCellStaticSata => _bedCellStaticSata;

    private void Start()
    {
        _bedMeshHandler = GetComponent<BedMeshHandler>();
    }

    public void SetBedType(BedCellStaticData bedCellStaticData)
    {
        _bedCellStaticSata = bedCellStaticData;
    }

    public void SetBedMesh()
    {
        _bedMeshHandler.SetBedMesh(BedCellStaticSata);
    }
}

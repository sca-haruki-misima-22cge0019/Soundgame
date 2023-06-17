using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinerNotesGenerator : MonoBehaviour
{

    [SerializeField] int startLane = 0; //�����O�m�[�c�̎n�_���ǂ��̃��[���ɂ��邩
    [SerializeField] int endLane = 2; //�����O�m�[�c�̏I�_���ǂ��̃��[���ɂ��邩
    [SerializeField] float startTim = 1.0f; //�����O�m�[�c�̎n�_������^�C�~���O
    [SerializeField] float endTim = 6.0f; //�����O�m�[�c�̏I�_������^�C�~���O

    float laneWidth = 2.0f;�@//���[���̑���( = �m�[�c�̑��� )

    void Start()
    {
        //�e�X�g�p
        GameObject testNotes = new GameObject();
        testNotes.AddComponent<MeshFilter>();
        testNotes.AddComponent<MeshRenderer>();

        //�ʒu���W�����߂�B
        Vector3 startPos = new Vector3(-2 * laneWidth + laneWidth * startLane + laneWidth / 2, 0.1f, startTim);
        Vector3 endPos = new Vector3(-2 * laneWidth + laneWidth * endLane + laneWidth / 2, 0.1f, endTim);

        //�����O�m�[�c����
        Generate(startPos, endPos, testNotes);
    }



    void Generate(Vector3 sPos, Vector3 ePos, GameObject notesObj)
    {
        //���b�V���𐶐����AMeshFilter�ɓn���B
        //MeshFilter��MeshRenderer�Ƀ��b�V����n���āA���b�V�����`�悳���B
        Mesh mesh = new Mesh();
        notesObj.GetComponent<MeshFilter>().mesh = mesh;

        Vector3[] vertices = new Vector3[4];
        int[] triangles = new int[6];

        vertices[0] = sPos + new Vector3(-laneWidth / 2, 0, 0);//�n�_�̍��[
        vertices[1] = sPos + new Vector3(laneWidth / 2, 0, 0); //�n�_�̉E�[
        vertices[2] = ePos + new Vector3(-laneWidth / 2, 0, 0); //�I�_�̍��[
        vertices[3] = ePos + new Vector3(laneWidth / 2, 0, 0); //�I�_�̉E�[

        triangles = new int[6] { 0, 2, 1, 3, 1, 2 };

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
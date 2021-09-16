using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndasDeAsteroides : MonoBehaviour
{
    public ComportamentoAsteroide prefabAsteroide;
    public int quantosAsteroides = 3;
    void Start()
    {
        for(int i = 0; i < quantosAsteroides; i++){
            float x = Random.Range(-8.0f, 8.0f);
            float y = Random.Range(-4.0f, 4.0f);
            
            Vector3 posicao = new Vector3(x, y, 0.0f); //TODO
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }

}
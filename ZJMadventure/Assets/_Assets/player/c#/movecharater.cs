using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class movecharater : MonoBehaviour
{}
	/*
    public Text tx;
    public groundtest groundt;
    public headtest headbox;
    public Text counttext;
    public float speed;
    private int jumptimes = 0;
    public int goals;
    private float movex;
    private Rigidbody2D m_Rigidbody2D;
    [SerializeField] private float MaxSpeed = 10f;
    [SerializeField] private float m_JumpForce = 400f;

    private bool ifjump;
    // Use this for initialization
    void Start()
    {

        movex = -1;
        ifjump = false;
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        //m_Rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        goals = 0;
        counttext.text = "原谅度:" + goals.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {

            ifjump = true;
        }
        if (transform.position.y < -10)
        {
            tx.text = "ZJM DIED";
            Invoke("Xrestart", 3f);
        }
    }
    void Xrestart()
    {
        
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }
    private void FixedUpdate()
    {
        if (groundt.onground == 1)
        {
            jumptimes = 0;
        }

        if (movex > -0.1 && movex < 0.1)
            movex = CrossPlatformInputManager.GetAxis("Horizontal");
        if (headbox.knock == 0)
            m_Rigidbody2D.velocity = new Vector2(movex * MaxSpeed, m_Rigidbody2D.velocity.y);
        movex = 0;
        if (ifjump)
        {
            ifjump = false;
            jumptimes++;
            if (jumptimes <= 2)
            {
                m_Rigidbody2D.velocity = new Vector2(m_Rigidbody2D.velocity.x, m_JumpForce);

            }
        }

    }
}*/

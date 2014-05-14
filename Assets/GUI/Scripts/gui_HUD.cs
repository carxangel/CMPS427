using UnityEngine;
using System.Collections;

public class gui_HUD : MonoBehaviour
{

    #region CLASS PROPERTIES

    // The Player Prefab so that we can get all info to display
    public Transform PlayerObj;

    // Textures for the HUD container
    public Texture hud_Overlay;
    public Texture hud_Backgrd;

    // Button Textures to open GUI Windows
    public Texture btn_Settings;
    public Texture btn_Attribute;
    public Texture btn_Spellbook;
    public Texture btn_Inventory;
    public Texture btn_Talents;

    // Prefabs for the animated meters
    public Transform meter_HP;
    public Transform meter_MP;
    public Transform meter_XP;


    // The different fonts that are used on the HUD
    public Font font_Text;
    public Font font_Title;
    public Font font_lgBitmap;
    public Font font_smBitmap;

    // Currently Equipped abilities display
    // + These are loaded from the currently assigned abilities.
    public Texture ability_Click;
    public Texture ability_Q;
    public Texture ability_W;
    public Texture ability_E;
    public Texture ability_R;


    // Calculated Variables to used to determine what is displayed
    [HideInInspector]
    public PlayerEntity Player;
    public float native_width;
    public float native_height;
    public float cur_HP;
    public float cur_MP;
    public float cur_XP;

    // GUI Components to be drawn
    public Rect hud_Base;
    public Rect hud_Frame;
    public Rect box_Settings;
    public Rect box_Attribute;
    public Rect box_Spellbook;
    public Rect box_Inventory;
    public Rect box_Talents;


    #endregion



    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	// Use this for initialization
	void Start () {
        native_width =  Screen.width;
        native_height = Screen.height;

        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEntity>();
        cur_HP = 1.0f;
        cur_MP = 1.0f;
        cur_XP = 0.0f;

        // Initialize HUD component positions
        hud_Base = new Rect(hud_Base.width * 0.5f,
                            Screen.height - hud_Base.height,
                            hud_Base.width,
                            hud_Base.height);



	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Draw the HUD elements on the GUI
    void OnGui()
    {
        float rx = Screen.width / native_width;
        float ry = Screen.height / native_height;
        GUI.matrix = Matrix4x4.TRS(new Vector3(0f, 0f, 0f), Quaternion.identity, new Vector3(rx, ry, 1));

       /* GUI.BeginGroup();
        {

        }*/


    }

}

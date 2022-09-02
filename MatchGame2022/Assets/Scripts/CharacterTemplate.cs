using UnityEngine;

[CreateAssetMenu]
public class CharacterTemplate : ScriptableObject
{
    // Attributes that could be applied to multiple different characters
    /* Name
     * Description
     * Image
     * Role (Mage, Warrior, Archer) Make these booleans?
     */

    public string characterName;
    public string catchPhrase;

    public int characterHp;
    
    public Sprite appearance;
    public string element;
    
    public bool mage;
    public bool warrior;
    public bool archer;
    
}

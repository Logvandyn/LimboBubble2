using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 11/23/23
 * Limbo Bubble feature overview
 */
public class Overview : MonoBehaviour
{
    ///<summary>
    ///
    /// This feature is focused around Limbo's ultimate ability from Warframe- a bubble which freezes all enemies and projectiles inside of it 
    /// There will be an enemy constantly in motion, which will slowly fire projectiles into the air (for visibility purposes)
    /// There will not be a player controller as all I am focusing on is the ability itself and how it affects the enemy 
    /// 
    /// The player will be able to click anywhere on the screen to summon the bubble 
    /// The bubble will slowly shrink until it disappears once reaching its smallest scale 
    /// The player cannot summon another bubble while the current one is active
    /// Clicking once again while a bubble is active immediatley destroys the active bubble 
    /// The player can then click to summon a new bubble 
    /// 
    /// If the enemy is not inside of the bubble, nothing will happen
    /// If the enemy enters the bubble, its movement and shooting will freeze
    /// If there is a projectile inside of the bubble, its momentum will stop as well
    /// Once the bubble disappears, enemy movement, projectile movement, and enemy firing will continue where it left off 
    /// 
    /// 
    /// <SCRIPTS_NEEDED>
    /// A player script to create and destroy the bubble
    /// A bubble script to make the bubble shrink and freeze enemies and projectiles
    /// An enemy script to fire projectiles and move across the screen 
    /// A projectile spawner script (this could be built into the enemy script)
    /// A projectile script to cause the projectile to fire 
    /// </SCRIPTS_NEEDED>
    /// 
    /// <UI_ELEMENTS>
    /// Overview UI will be needed to show the player the controls 
    /// </UI_ELEMENTS>
    ///
    ///</summary>
}

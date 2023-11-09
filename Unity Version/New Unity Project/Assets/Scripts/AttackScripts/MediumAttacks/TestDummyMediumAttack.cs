using UnityEngine;

namespace AttackScripts.MediumAttacks
{
    public class TestDummyMediumAttack : IAttackBehaviour
    {
        public void PerformAttack()
        {
            Debug.Log("Medium attack performed");
        }
    }
}
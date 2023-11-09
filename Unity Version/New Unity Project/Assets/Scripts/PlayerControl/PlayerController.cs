using System;
using AttackScripts;
using AttackScripts.HeavyAttacks;
using AttackScripts.LightAttacks;
using AttackScripts.MediumAttacks;
using UnityEngine;
using UnityEngine.Serialization;

namespace PlayerControl
{
    public abstract class PlayerController : MonoBehaviour
    {
        [Header("Variables")]
        public float stunTimer;

        [Header("Character move's")] 
        [SerializeField, SerializeReference]
        private IAttackBehaviour _lightAttack; 
        [SerializeField, SerializeReference]
        private IAttackBehaviour _mediumAttack; 
        [SerializeField, SerializeReference]
        private IAttackBehaviour _heavyAttack;
        
        [FormerlySerializedAs("_testInt")] [SerializeField]
        private int testInt;
        
        protected void SetAttacks(IAttackBehaviour lightAttack, IAttackBehaviour mediumAttack, IAttackBehaviour heavyAttack)
        {
            _lightAttack = lightAttack;
            _mediumAttack = mediumAttack;
            _heavyAttack = heavyAttack;
        }

        protected abstract void SetAttacksRunner();

        private void Start()
        {
            SetAttacksRunner();
        }

        void Update()
        {
            if (!IsStunned())
            {
                HandleControls();
            }
        }

        Boolean IsStunned()
        {
            if (0.0f <= stunTimer)
            {
                stunTimer -= Time.deltaTime;
                return true;
            }
            return false;
        }

        void HandleControls()
        {
            switch (testInt)
            {
                case 1:
                    _lightAttack.PerformAttack();
                    break;
                case 2:
                    _mediumAttack.PerformAttack();
                    break;
                case 3:
                    _heavyAttack.PerformAttack();
                    break;
            }
        }
    }
}


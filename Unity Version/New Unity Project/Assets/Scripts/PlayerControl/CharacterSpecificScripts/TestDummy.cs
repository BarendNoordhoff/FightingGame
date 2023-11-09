using AttackScripts.HeavyAttacks;
using AttackScripts.LightAttacks;
using AttackScripts.MediumAttacks;

namespace PlayerControl.CharacterSpecificScripts
{
    public class TestDummy : PlayerController
    {
        protected override void SetAttacksRunner()
        {
            this.SetAttacks(new TestDummyLightAttack(), new TestDummyMediumAttack(), new TestDummyHeavyAttack());
        }
    }
}
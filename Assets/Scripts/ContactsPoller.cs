 using UnityEngine;

public class ContactsPoller
{
    private const float CollisionTresh = 0.1f;

    private ContactPoint2D[] _contacts = new ContactPoint2D[10];
    private Collider2D _collider;

    public bool IsGrounded { get; private set; }
    public bool HasLeftContacts { get; private set; }
    public bool HasRightContacts { get; private set; }


    public ContactsPoller(Collider2D collider)
    {
        _collider = collider;
    }

    public void Update()
    {
        IsGrounded = false;
        HasLeftContacts = false;
        HasRightContacts = false;

        var contactsCount = _collider.GetContacts(_contacts);

        for (var i =0; i < contactsCount; i++)
        {
            var normal = _contacts[i].normal;
            var rigidbody = _contacts[i].rigidbody;

            if (normal.y > CollisionTresh)
                IsGrounded = true;

            if (normal.x > CollisionTresh && rigidbody == null)
                HasLeftContacts = true;

            if (normal.x < -CollisionTresh && rigidbody == null)
                HasRightContacts = true;

        }

    }

}

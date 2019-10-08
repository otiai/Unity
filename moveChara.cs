/// <summary>Playerの最大速度</summary>
[SerializeField] float maxSpeed = 10;

private Rigidbody m_rigidbody;

void Reset()
{
	Awake();
}

void Awake()
{
	m_rigidbody = GetComponent<Rigidbody>();
}

void Update()
{
	//平行移動
	float x = Input.GetAxis("Horizontal");
	//上下移動
	float z = Input.GetAxis("Vertical");
	Move(x, z);
}

void Move(float movex, float movez)
{
	//速度を与える
	m_rigidbody.velocity = new Vector3(movex * maxSpeed, m_rigidbody.velocity.y, movez * maxSpeed);
}

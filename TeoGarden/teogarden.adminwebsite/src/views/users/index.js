import userApi from "../../api/userApi";
import { CDBTable, CDBTableHeader, CDBTableBody } from "cdbreact";
import { useEffect, useState } from "react";

function Users(){
  const [usersList, setProducts] = useState([]);

  useEffect(() => async () =>{
    const data = await userApi.GetAll();
    setProducts(data);
  }, []);
    
  return (
    <div>
      <div style={{flex:"1 1 auto", display:"flex", flexFlow:"column", height:"100vh", overflowY:"hidden"}}>
        <div style={{height:"100%"}}>
          <div style={{padding:"20px 5%",height:"calc(100% - 64px)",overflowY:"scroll"}}>
            <div style={{gridTemplateColumns:"repeat(1, minmax(200px, 700px))"}}>
              <div className="mt-5 w-100">
                <h4 className="font-weight-bold mb-3">Danh sách tài khoản khách hàng</h4>
                <CDBTable striped responsive>
                  <CDBTableHeader>
                    <tr>
                      <th>#</th>
                      <th>Họ tên</th>
                      <th>Địa chỉ</th>
                      <th>Số điện thoại</th>
                      <th>Email</th>
                    </tr>
                  </CDBTableHeader>
                  <CDBTableBody>
                    {usersList.map((u,key) => (
                      <tr key={u.id}>
                        <td>{key+1}</td>
                        <td>{u.name}</td>
                        <td>{u.address}</td>
                        <td>{u.phone}</td>
                        <td>{u.email}</td>
                      </tr>
                    ))}
                  </CDBTableBody>
                </CDBTable>
              </div>
            </div>      
          </div>
        </div>
      </div>
    </div>
  );
}

export default Users;
import { useEffect, useState } from "react";
import {Link} from "react-router-dom";
import Table from 'react-bootstrap/Table';
import {Button} from "reactstrap"
import productApi from "../../api/productApi";

function Products(){
  const [productsList, setProducts] = useState([]);

  useEffect(() => async () =>{
    const data = await productApi.GetAll();
    setProducts(data);
  }, []);
    
  return (
    <div>
      <div style={{flex:"1 1 auto", display:"flex", flexFlow:"column", height:"100vh", overflowY:"hidden"}}>
        <div style={{height:"100%"}}>
          <div style={{padding:"20px 5%",height:"calc(100% - 64px)",overflowY:"scroll"}}>
            <div style={{gridTemplateColumns:"repeat(1, minmax(200px, 700px))"}}>
              <div className="mt-5 w-100">
                <h4 className="font-weight-bold mb-3">Danh sách sản phẩm</h4>
                <Link to="/products/add"><Button color="success"><i class='bx bx-plus' ></i>Sản phẩm mới</Button></Link>
                <Table className="mt-3" striped bordered hover>
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Tên sản phẩm</th>
                      <th>Trọng lượng</th>
                      <th>Giá tiền</th>
                      <th>Hình ảnh</th>
                      <th>Nguồn gốc</th>
                      <th>Chỉnh sửa</th>
                      <th>Xóa</th>
                    </tr>
                  </thead>
                  <tbody>
                    {productsList.map((ca, key) => (
                      <tr key={ca.id}>
                        <td>{key+1}</td>
                        <td>{ca.name}</td>
                        <td>{ca.weight}</td>
                        <td>{ca.price}</td>
                        <td><img src={ca.image} style={{width: "100px"}}/></td>
                        <td>{ca.location}</td>
                        <td>
                        <Link to={`/products/update/${ca.id}`}><Button className="me-2" color="warning"><i class='bx bxs-edit'></i></Button></Link>
                        </td>
                        <td>
                          <Link to={`/products/delete/${ca.id}`}><Button color="danger"><i class='bx bx-x-circle'></i></Button></Link>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </Table>
              </div>
            </div>      
          </div>
        </div>
      </div>
    </div>
  );
}

export default Products;
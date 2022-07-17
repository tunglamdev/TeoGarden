import Button from 'react-bootstrap/Button';
import { useState , useEffect } from "react";
import Form from 'react-bootstrap/Form';
import { useForm } from "react-hook-form"
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Products from './index';
import productApi from "../../api/productApi";
import imageApi from "../../api/imageApi";
import {useNavigate, useParams} from "react-router-dom";

function Update() {
    const [show] = useState(true);
    const { register, handleSubmit } = useForm();
    const refresh = useNavigate();
    const {id} = useParams();

    const [imageUploadFile, setImageUploadFile] = useState(null);
    const onFileChange = (event) => {
        setImageUploadFile(event.target.files[0]);
    };

    const [product, setProduct] = useState([]);
    useEffect(() => async () =>{
        const data = await productApi.GetById(id);
        setProduct(data);
    }, []);
    const updateProduct = async (content) => {
        if(content.Name ==""
            && content.Price ==""
            && content.Weight ==""
            && content.Location =="" 
            && content.Image.length == 0);
        else{
            content.Id = product.id;
            content.categoryId = product.categoryId;
            if(content.Name =="") content.Name = product.name;
            if(content.Price =="") content.Price = product.price;
            if(content.Weight =="") content.Weight = product.weight;
            if(content.Location =="") content.Location = product.location;
            if(content.Image.length == 0) content.Image = "";
            else {
                const formData = new FormData();
                formData.append("File", imageUploadFile);
                content.Image = await imageApi.Upload(formData, "vegetables");
            }
            var oldFileName = await productApi.Update(content);
            console.log(oldFileName);
            if(oldFileName == "");
            else imageApi.Delete("vegetables", oldFileName);
        }
        refresh(-1);
    }

    return (
        <>
            <Products />

            <Modal show={show} backdrop="static">
                <Form onSubmit={handleSubmit(updateProduct)}>
                    <Modal.Header>
                        <Modal.Title>Cập nhật sản phẩm</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Form.Control
                            type="text"
                            {...register("Id")}
                            hidden
                        />
                        <Form.Control
                            type="text"
                            {...register("categoryId")}
                            hidden
                        />
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Tên sản phẩm</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Name")}
                                placeholder=""
                                defaultValue={product.name}
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Trọng lượng (gram)</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Weight")}
                                placeholder=""
                                defaultValue={product.weight}
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Giá bán (VND)</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Price")}
                                placeholder=""
                                defaultValue={product.price}
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Thông tin nguồn gốc</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Location")}
                                placeholder=""
                                defaultValue={product.location}
                            />
                        </Form.Group>
                        <Form.Group controlId="formFile" className="mb-3">
                            <Form.Label>Hình ảnh</Form.Label>
                            <Form.Control 
                                type="file"
                                {...register("Image")}
                                onChange={onFileChange}
                             />
                        </Form.Group>
                    </Modal.Body>
                    <Modal.Footer>
                        <Link to="/products"><Button variant="secondary">Thoát</Button></Link>
                        <Button type="submit" variant="warning">Cập nhật</Button>
                    </Modal.Footer>
                </Form>
            </Modal>
        </>
    );
}

export default Update;
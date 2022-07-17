import Button from 'react-bootstrap/Button';
import { useState, useEffect } from "react";
import Form from 'react-bootstrap/Form';
import { useForm } from "react-hook-form"
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Products from './index';
import productApi from "../../api/productApi";
import categoryApi from "../../api/categoryApi";
import imageApi from "../../api/imageApi";
import {useNavigate} from "react-router-dom";

function Create() {
    const [show] = useState(true);
    const { register, handleSubmit } = useForm();
    const refresh = useNavigate();

    const [imageUploadFile, setImageUploadFile] = useState(null);
    const onFileChange = (event) => {
        setImageUploadFile(event.target.files[0]);
    };

    const [categoriesList, setCategories] = useState([]);
    useEffect(() => async () =>{
        const data = await categoryApi.GetAll();
        setCategories(data);
    }, []);

    const addProduct = async (content) => {
        if(content.Image.length == 0)content.Image = 'default.jpg';
        else {
            const formData = new FormData();
            formData.append("File", imageUploadFile);
            content.Image = await imageApi.Upload(formData, "vegetables");
        }
        var res = await productApi.Create(content);
        refresh(-1);
    }

    return (
        <>
            <Products />

            <Modal show={show} backdrop="static">
                <Form onSubmit={handleSubmit(addProduct)}>
                    <Modal.Header>
                        <Modal.Title>Thêm sản phẩm</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Chọn loại sản phẩm</Form.Label>
                            <Form.Select autoFocus {...register("CategoryId")} required>
                                <option disabled selected>Chọn</option>
                                {categoriesList.map(ca => (
                                    <option value={ca.id}>{ca.name}</option>
                                ))}
                            </Form.Select>
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Tên sản phẩm</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Name")}
                                placeholder="Nhập tên sản phẩm"
                                required
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Trọng lượng</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Weight")}
                                placeholder="Nhập trọng lượng sản phẩm (gram)"
                                required
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Giá bán</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Price")}
                                placeholder="Nhập giá bán mỗi sản phẩm (VND)"
                                required
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Thông tin nguồn gốc</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Location")}
                                placeholder="Nhập giá thông tin nguồn gốc sản phẩm"
                                required
                            />
                        </Form.Group>
                        <Form.Group controlId="formFile" className="mb-3">
                            <Form.Label>Hình ảnh sản phẩm</Form.Label>
                            <Form.Control 
                                type="file"
                                {...register("Image")}
                                onChange = {onFileChange}
                             />
                        </Form.Group>
                    </Modal.Body>
                    <Modal.Footer>
                        <Link to="/products"><Button variant="secondary">Thoát</Button></Link>
                        <Button type="submit" variant="success">Thêm</Button>
                    </Modal.Footer>
                </Form>
            </Modal>
        </>
    );
}

export default Create;
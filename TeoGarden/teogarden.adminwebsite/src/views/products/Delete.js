import Button from 'react-bootstrap/Button';
import { useState } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Products from './index';
import productApi from "../../api/productApi";
import {useNavigate, useParams} from "react-router-dom";

function Delete() {
    const [show] = useState(true);
    const refresh = useNavigate();
    const {id} = useParams();

    const deleteProduct = async () => {
        var res = await productApi.Delete(id);
        refresh(-1);
    }

    return (
        <>
            <Products />

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Xóa sản phẩm</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    Bạn chắc chắn muốn xóa sản phẩm này?
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/products"><Button variant="secondary">Thoát</Button></Link>
                    <Button onClick={deleteProduct} variant="danger">Xóa</Button>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default Delete;
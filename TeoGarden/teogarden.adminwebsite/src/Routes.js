import React, { Fragment } from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Admin from './layouts/Admin';

import Categories from './views/categories/index';
import CategoryCreate from './views/categories/Create';
import CategoryUpdate from './views/categories/Update';
import CategoryDelete from './views/categories/Delete';

import Products from './views/products/index';
import ProductCreate from './views/products/Create';
import ProductUpdate from './views/products/Update';
import ProductDelete from './views/products/Delete';

import Users from './views/users/index';

const URL = () => {

    return (
        <BrowserRouter>
        <Routes>
            <Route path="/" element={<Admin />}>
                <Route path="/home" element={<Products />}/>

                <Route path="/categories" element={<Categories />}/>
                <Route path="/categories/add" element={<CategoryCreate />}/>
                <Route path="/categories/update/:id" element={<CategoryUpdate />}/>
                <Route path="/categories/delete/:id" element={<CategoryDelete />}/>

                <Route path="/products" element={<Products />}/>
                <Route path="/products/add" element={<ProductCreate />}/>
                <Route path="/products/update/:id" element={<ProductUpdate />}/>
                <Route path="/products/delete/:id" element={<ProductDelete />}/>
                
                <Route path="/users" element={<Users />}/>
            </Route>
        </Routes>
        </BrowserRouter>
      );
};

export default URL;

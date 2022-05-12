import React from 'react';
import PropTypes from 'prop-types';

export const SearchData = ({searchVal, onChange, onSubmit}) => (
    <div className="row justify-content-center">
      <form className="row row-cols-lg-auto g-3" onSubmit={onSubmit}>
        <div className="col">
          <input
              type="text"
              className="form-control mb-2 mr-sm-2"
              placeholder="Search phrase..."
              value={searchVal}
              name="searchVal"
              onChange={onChange}
          />
        </div>
        <div className="col">
          <button type="submit" className="btn btn-primary mb-2 pxy-4">Search</button>
        </div>
      </form>

    </div>
);

SearchData.propTypes = {
    searchVal: PropTypes.string.isRequired,
    onChange: PropTypes.func.isRequired,
    onSubmit: PropTypes.func.isRequired,
};